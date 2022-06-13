import 'package:flutter/material.dart';
import 'package:moby_shop/models/Artikli.dart';
import 'package:moby_shop/models/CartModel.dart';

class CartService{
  static Map<String, CartModel> artikli= new Map<String, CartModel>();

  static void RemoveProduct(String id){
    artikli.remove(id);
  }

  static void AddProduct(Artikli artikal, int kolicina){
    CartModel cm = new CartModel();
    cm.artikal=artikal;
    cm.kolicina=kolicina;
    Map<String, CartModel> map= {'${artikal.artikalId}': cm};
    if(!artikli.containsKey('${artikal.artikalId}')) {
      artikli.addAll(map);
       print('${map['${artikal.artikalId}']?.artikal.naziv}  ${map['${artikal.artikalId}']?.kolicina}');
    }
    else{
      var cm=artikli['${artikal.artikalId}'];
      cm?.kolicina+=1;
      artikli.update('${artikal.artikalId}', (value) => cm!);
      print(cm?.kolicina);
    }
  }
}