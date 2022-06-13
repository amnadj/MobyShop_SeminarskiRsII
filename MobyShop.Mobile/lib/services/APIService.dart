import 'dart:convert';
import 'dart:io';
import 'package:flutter/foundation.dart';
import 'package:http/http.dart' as http;

String server_adress =  "http://10.0.2.2:5000/api/";

class APIService{
  static String? username;
  static String? password;
  String route;

  APIService({required this.route});

  void SetParameter(String Username, String Password){
    username=Username;
    password=Password;
  }


  static Future<List<dynamic>?> Get(String route, dynamic object) async{
    String queryString = Uri(queryParameters: object).query;
    String baseUrl=server_adress+route;

    if(object!=null){
      baseUrl = baseUrl + '?' + queryString;
    }

    final String basicAuth='Basic '+base64Encode(utf8.encode('$username:$password'));

    final response= await http.get(
      Uri.parse(baseUrl),
      headers: {HttpHeaders.authorizationHeader:basicAuth},
    );

    if(response.statusCode==200){
      return json.decode(response.body);
    }
  }

 static Future<dynamic> GetById(String route, dynamic id) async{
   String baseUrl=server_adress + route + "/" + id;
   final String basicAuth='Basic '+base64Encode(utf8.encode('$username:$password'));
   final response= await http.get(
     Uri.parse(baseUrl),
     headers: {HttpHeaders.authorizationHeader:basicAuth},
   );
   if(response.statusCode==200)
     return json.decode(response.body);
   return null;
 }


  /*static Future<dynamic> getProizvodjac(String route) async {
    String baseUrl=server_adress+route;

      baseUrl = baseUrl + '?';

    final String basicAuth =
        'Basic ' + base64Encode(utf8.encode('$username:$password'));

    final response = await http.get(
      Uri.parse(baseUrl),
      headers: {HttpHeaders.authorizationHeader:basicAuth},
    );

    if (response.statusCode == 200) {
      return json.decode(response.body);
    } else if (response.statusCode == 400) {
      return json.decode(response.body);
    } else {
      return null;
    }

  }*/
}