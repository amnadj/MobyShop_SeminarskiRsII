import 'dart:convert';
import 'dart:io';
import 'package:http/http.dart' as http;

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
    String baseUrl="http://192.168.0.80:5000/api/"+route;

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
   String baseUrl="http://192.168.0.206:5000/"+ route + "/" + id;
   final String basicAuth='Basic '+base64Encode(utf8.encode('$username:$password'));
   final response= await http.get(
     Uri.parse(baseUrl),
     headers: {HttpHeaders.authorizationHeader:basicAuth},
   );
   if(response.statusCode==200)
     return json.decode(response.body);
   return null;
 }


// static Future<dynamic> Post(String route, String body) async {
//   String baseUrl="http://172.26.16.1:5010/"+route;
//   final response = await http.post(
//     Uri.parse(baseUrl),
//     headers: <String, String>{
//       'Content-Type': 'application/json; charset=UTF-8',
//     },
//     body: body,
//   );
//
//   if (response.statusCode == 201) {
//     ...
//   }
// }

  /*static Future<dynamic> getProizvodjac(String route) async {
    String baseUrl="http://192.168.0.206:5000/api/"+route;

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