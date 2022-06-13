import 'dart:typed_data';
import 'dart:ui';
import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'dart:io';
import 'dart:convert';

import 'package:moby_shop/models/Artikli.dart';
import 'package:moby_shop/models/Proizvodjaci.dart';
import 'package:moby_shop/services/APIService.dart';
import 'package:moby_shop/services/CartService.dart';

class ArtikliDetalji extends StatelessWidget {
  final Artikli? artikal;
  int? id = null;
  ArtikliDetalji({Key? key, this.artikal}) : super(key: key);


  Future<Proizvodjaci?> GetProizvodjac(int id) async {

    return await APIService.GetById('Proizvodjaci', id);
  }

  /*@override
  Widget build(BuildContext context) {
    return FutureBuilder<String>(
      future: GetProizvodjac(id!), // function where you call your api
      builder: (BuildContext context, AsyncSnapshot<String> snapshot) {  // AsyncSnapshot<Your object type>
        if( snapshot.connectionState == ConnectionState.waiting){
          return  Center(child: Text('Please wait its loading...'));
        }else{
          if (snapshot.hasError)
            return Center(child: Text('Error: ${snapshot.error}'));
          else
            return Center(child: new Text('${snapshot.data}'));  // snapshot.data  :- get your object which is pass from your downloadData() function
        }
      },
    );
  }*/

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text(
          'Detalji artikla',
          style: const TextStyle(fontSize: 20),
        ),
        backgroundColor: Colors.blueGrey,
      ),
      body:
      Column(
        children: [
          Padding(
          padding: const EdgeInsets.all(20),
            child: Row(
              children: [
                Image(
                  height: 150, width: 150, image: Image.memory(Uint8List.fromList(artikal?.slika as List<int>)).image,
                ),
                Padding(
                  padding: const EdgeInsets.all(0),
                  child: Column(
                    children: [
                      Padding(
                        padding: const EdgeInsets.all(9.0),
                        child: Text(
                          '${artikal?.naziv}',
                          style: const TextStyle(color: Colors.black, fontWeight: FontWeight.bold),
                        ),
                      ),
                      Text(
                        '(${artikal?.cijena} KM)',
                        style: const TextStyle(color: Colors.black),
                      ),

                    ],
                  ),
                ),
]
            ),
          ),

          Padding(padding: const EdgeInsets.all(20),
          child:
              Column(children:[
          Row(
            children: [
              Text(
                'Model: ${artikal?.model}',
                style: const TextStyle(color: Colors.black, fontWeight: FontWeight.bold, fontSize: 15),
              ),
            ],
          ),
          Row(
            children: [
              Text(
                'Proizvodjac: ${artikal?.proizvodjac}',
                style: const TextStyle(color: Colors.black, fontWeight: FontWeight.bold, fontSize: 15),
              ),
            ],
          ),
    ])
    ),
          Center(
            child: Padding(
              padding: const EdgeInsets.only(left: 127.0),
              child: Row(
                children: [
                  TextButton(
                    onPressed: (){
                      CartService.AddProduct(artikal!, 1);
                      Navigator.of(context).pushReplacementNamed('/narudzbe');
                    },
                    child: const Image(
                        width: 100,
                        height: 100,
                        image: AssetImage('assets/cart.png')),
                  ),
                ],
              ),
            ),
          ),
    RatingBar.builder(
      initialRating: 3,
      minRating: 1,
      direction: Axis.horizontal,
      allowHalfRating: true,
      itemCount: 5,
      itemPadding: const EdgeInsets.symmetric(horizontal: 4.0),
      itemBuilder: (context, _) => const Icon(
        Icons.star,
        color: Colors.blueGrey,
      ),
      onRatingUpdate: (rating) {
        print(rating);
        },
    ),
        ]),
    );
  }
}

