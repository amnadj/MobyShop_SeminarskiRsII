class Modeli{
  int? modelId;
  String ?naziv;

  Modeli({
     this.modelId,
     this.naziv,
  });

  factory Modeli.fromJson(Map<String, dynamic> json){
    return Modeli(
      modelId:int.parse(json["modelId"].toString()),
      naziv: json["naziv"],
    );
  }

  Map<String, dynamic> toJson() => {
    "modelId": modelId,
    "naziv": naziv,
  };
}