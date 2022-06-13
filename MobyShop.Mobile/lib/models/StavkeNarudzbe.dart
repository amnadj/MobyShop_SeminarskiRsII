class StavkeNarudzbe{
  int? narudzbaStavkaId;
  int? narudzbaId;
  int? artikalId;
  int? kolicina;

  StavkeNarudzbe({this.narudzbaStavkaId, this.narudzbaId, this.artikalId, this.kolicina});

  factory StavkeNarudzbe.fromJson(Map<String, dynamic> json){
    return StavkeNarudzbe(
      narudzbaStavkaId:int.parse(json["narudzbaStavkaID"].toString()),
      narudzbaId: int.parse(json["narudzbaID"].toString()),
      artikalId: int.parse(json["proizvodID"].toString()),
      kolicina: json["kolicina"],
    );
  }

  Map<String, dynamic> toJson() => {
    "narudzbaStavkaId": narudzbaStavkaId,
    "narudzbaId": narudzbaId,
    "artikalId": artikalId,
    "kolicina": kolicina,
  };
}