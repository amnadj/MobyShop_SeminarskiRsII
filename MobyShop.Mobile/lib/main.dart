import 'package:flutter/material.dart';
import 'package:moby_shop/pages/ArtikliDetalji.dart';
import 'package:moby_shop/pages/ExistingCardsPage.dart';
import 'package:moby_shop/pages/Narudzba.dart';
import 'package:moby_shop/pages/Payment.dart';
import 'package:moby_shop/pages/Products.dart';
import 'package:moby_shop/pages/Home.dart';
import 'package:moby_shop/pages/Loading.dart';
import 'package:moby_shop/pages/Login.dart';

Future<void> main() async {
  runApp(MyApp());
}
class MyApp extends StatelessWidget {
  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home:Login(),
      routes: {
        '/loading':(context)=>Loading(),
        '/home':(context)=>Home(),
        '/artikli':(context)=>Products(),
        '/artiklidetalji':(context)=> ArtikliDetalji(),
        '/narudzbe':(context)=>Narudzba(),
        '/payment':(context)=>Payment(),
        '/cards':(context)=>ExistingCardsPage()
      },
    );
  }
}
