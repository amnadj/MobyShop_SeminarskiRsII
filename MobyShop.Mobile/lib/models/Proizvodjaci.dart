class Proizvodjaci{
  int? proizvodjacId;
  String ?naziv;

  Proizvodjaci({
    this.proizvodjacId,
    this.naziv,
  });

  factory Proizvodjaci.fromJson(Map<String, dynamic> json){
    return Proizvodjaci(
      proizvodjacId:int.parse(json["proizvodjacId"].toString()),
      naziv: json["naziv"] as String,
    );
  }

  Map<String, dynamic> toJson() => {
    "proizvodjacId": proizvodjacId,
    "naziv": naziv,
  };
  }