import 'package:flutter/material.dart';
import 'dart:collection';
import 'dart:convert';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:moby_shop/services/CartService.dart';
import 'package:collection/collection.dart';

class Narudzba extends StatefulWidget {

  @override
  _NarudzbaState createState() => _NarudzbaState();
}

class _NarudzbaState extends State<Narudzba> {

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Narudzba'),
        backgroundColor: Colors.blueGrey,
      ),
      body: Column(
        mainAxisAlignment: MainAxisAlignment.start,
        children: [
        ListView(
      shrinkWrap: true,
          children:
          CartService.artikli.values.map((e) => CustomCard(e)).toList(),
        ),
    ElevatedButton(
    onPressed: (){
      if(CartService.artikli.length > 0) {
        Navigator.of(context).pushReplacementNamed('/payment');
      }
    },
      child: Text('Zakljuci narudzbu')
    ),],)


    );
  }

  void incrementValue(String id, bool add) {
    setState(() {
      var cm = CartService.artikli[id];
      if (add)
        cm?.kolicina = cm.kolicina + 1;
      else
        cm?.kolicina = cm.kolicina - 1;

      if (cm?.kolicina == 0)
        CartService.RemoveProduct(id);
      else
        CartService.artikli[id] = cm!;
      print(cm?.kolicina);
    });
  }

  Widget CustomCard(cart) {
    return Card(
        child: Padding(
          padding: EdgeInsets.all(20),
          child: Row(
            children: [
              Expanded(
                  child: Text(
                    cart.artikal.naziv,
                    style: TextStyle(fontSize: 20),
                  )),
              Expanded(
                child: Row(
                  children: [
                    TextButton(
                      onPressed: () {
                        incrementValue(
                            cart.artikal.artikalId.toString(), false);
                      },
                      child: Icon(Icons.remove, color: Colors.blueGrey),
                    ),
                    SizedBox(
                      width: 5,
                    ),
                    Text(
                      cart.kolicina.toString(),
                      style: TextStyle(fontSize: 20),
                    ),
                    SizedBox(
                      width: 1,
                    ),
                    TextButton(
                      onPressed: () {
                        incrementValue(
                            cart.artikal.artikalId.toString(), true);
                      },
                      child: Icon(Icons.add, color: Colors.blueGrey),
                    )
                  ],
                ),

              ),

            ],

          ),

        )
    );
  }
}