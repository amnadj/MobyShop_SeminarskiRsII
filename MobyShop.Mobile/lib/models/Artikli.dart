import 'dart:convert';
import 'dart:typed_data';

class Artikli {
  final int? artikalId;
  final String? naziv;
  final String? cijena;
  final List<int>? slika;
  final String? proizvodjac;
  final String? model;
  final bool? status;
  final int? modelId;

  Artikli({
    this.artikalId,
    this.naziv,
    this.cijena,
    this.slika,
    this.proizvodjac,
    this.model,
    this.status,
    this.modelId
  });

  factory Artikli.fromJson(Map<String, dynamic> json){
    String stringByte = json["slika"] as String;
    List<int>? bytes=base64.decode(stringByte);
    return Artikli(
      artikalId:int.parse(json["artikalId"].toString()),
      naziv: json["naziv"],
      cijena: json["cijena"].toString(),
      slika: bytes,
      proizvodjac: json["proizvodjac"].toString(),
      model: json["model"].toString(),
      status: json["status"],
      modelId:  json["modelId"] as int,
    );
  }

  Map<String, dynamic> toJson() => {
    "artikalId": artikalId,
    "naziv": naziv,
    "cijena": cijena,
    "slika": slika,
    "proizvodjac":proizvodjac,
    "model":model,
    "status": status,
    "modelId":modelId
  };
}