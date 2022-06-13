import 'dart:async';
import 'dart:convert';
import 'dart:typed_data';
import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:moby_shop/models/Artikli.dart';
import 'package:moby_shop/models/Modeli.dart';
import 'package:moby_shop/pages/ArtikliDetalji.dart';
import 'package:moby_shop/services/APIService.dart';
import 'package:collection/collection.dart';

class Products extends StatefulWidget {
  final Artikli? artikal = null;

  @override
  _ProductsState createState() => _ProductsState();
}

class _ProductsState extends State<Products> {
  Modeli? _selectedModeli = null;
  List<DropdownMenuItem> items = [];
  List<Artikli> artikli = [];

  Future<void> GetProducts() async {
    // Map<String, String>? queryParams = null;
    // if (selectedItem != null && selectedItem.modelId != 0)
    //   queryParams = {'ModelId': selectedItem.modelId.toString()};

    var a = await APIService.Get('Artikli', null);
    setState(() {
      artikli = a!.map((e) => Artikli.fromJson(e)).toList();
    });
  }

  @override
  void initState() {
    super.initState();
    GetProducts();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Artikli'),
        backgroundColor: Colors.blueGrey,
      ),
      body: Column(
        children: [
          Center(child: dropDownWidget()),
          Expanded(child: bodyWidget()),
          Padding(
            padding: const EdgeInsets.only(bottom: 20.0, right: 20),
            child: IconButton(
    icon: Icon(
    Icons.refresh_outlined,
    color: Colors.blueGrey,
    size: 50,
    ),
    onPressed: () {
    setState(() {
    GetProducts();
    });
    },
    ),
          ),
        ],
      ),
    );
  }

  Widget dropDownWidget() {
    return FutureBuilder<List<Modeli>>(
        future: GetProductsTypes(_selectedModeli),
        builder: (BuildContext context, AsyncSnapshot<List<Modeli>> snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return Center(
              child: Text('Loading...'),
            );
          } else {
            if (snapshot.hasError) {
              return Center(
                child: Text('${snapshot.error}'),
              );
            } else {
              return Padding(
                padding: EdgeInsets.fromLTRB(30, 10, 30, 10),
                child: DropdownButton<dynamic>(
                  hint: Text('Odaberite vrstu proizvoda'),
                  isExpanded: true,
                  items: items,
                  onChanged: (newVal) {
                    setState(() {
                      _selectedModeli = newVal;
                      filtriraj(_selectedModeli);
                    });
                  },
                  value: _selectedModeli,
                ),
              );
            }
          }
        });
  }

  Future<List<Modeli>> GetProductsTypes(Modeli? selectedItem) async {
    var modeli = await APIService.Get('Modeli', null);
    var modeliList = modeli?.map((i) => Modeli.fromJson(i)).toList();

    items = modeliList!.map((item) {
      return DropdownMenuItem<Modeli>(
        value: item,
        child: Text(item.naziv.toString()),
      );
    }).toList();


    if (selectedItem != null && selectedItem.modelId != 0)
      _selectedModeli = modeliList
          .where((element) => element.modelId == selectedItem.modelId)
          .first;
    else
      _selectedModeli = modeliList.first;
    // else
    // _selectedModeli = modeliList.where ((e) => e.modelId != null).first;


    return modeliList;
  }

  Widget bodyWidget() {
    return FutureBuilder<List<Artikli>>(
        builder: (BuildContext context, AsyncSnapshot<List<Artikli>> snapshot) {
          if (snapshot.connectionState == ConnectionState.waiting) {
            return Center(
              child: Text('Loading...'),
            );
          } else {
            if (snapshot.hasError) {
              return Center(
                child: Text('${snapshot.error}'),

              );
            } else {
              return ListView(
                children: artikli.map((e) => ProizvodiWidget(e)).toList(),
              );
            }}
        });
  }

  void filtriraj(Modeli? selectedItem) {
    print(selectedItem?.modelId);
    print(artikli[2].modelId);
    setState(() {
      artikli = artikli
          .where((element) => element.model == selectedItem?.naziv)
          .toList();
    });
  }

  Widget ProizvodiWidget(Artikli artikli) {
    print(artikli);
    return Card(
      child: TextButton(
        onPressed: () {
          Navigator.push(
              context,
              MaterialPageRoute(
                  builder: (context) => ArtikliDetalji(
                    artikal: artikli,
                  )));
        },
        child: Padding(
          padding: EdgeInsets.all(20),
          child: Row(
            children: [
              Image(
                height: 80,
                width: 80,
                image:
                Image.memory(Uint8List.fromList(artikli.slika as List<int>))
                    .image,
              ),
              Padding(
                padding: EdgeInsets.all(30),
                child: Column(
                  children: [
                    Text(
                      '${artikli.naziv!}',
                      style: TextStyle(color: Colors.black),
                    ),
                    Text(
                      '(${artikli.cijena} KM)',
                      style: TextStyle(color: Colors.black),
                    ),
                  ],
                ),
              )
            ],
          ),
        ),
      ),
    );
  }
}