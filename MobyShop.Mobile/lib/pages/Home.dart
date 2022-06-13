import 'package:flutter/material.dart';

class Home extends StatefulWidget {
  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Menu'),
        backgroundColor: Colors.blueGrey,
      ),
      drawer: Drawer(
        child: ListView(
          children: [
            DrawerHeader(child: Center(child: Text('Moby Shop', style: TextStyle(fontSize: 20, color: Colors.white),)),
              decoration: BoxDecoration(
                  color: Colors.blueGrey
              ),
            ),
            ListTile(
              title: Text('Artikli'),
              onTap: () {
                Navigator.of(context).pushNamed('/artikli');
              },
            ),
            ListTile(
              title: Text('Narudzba'),
              onTap: () {
                Navigator.of(context).pushNamed('/narudzbe');
              },
            ),
            ListTile(
              title: Text('Placanje'),
              onTap: () {
                Navigator.of(context).pushNamed('/payment');
              },
            )
          ],
        ),
      ),
    );
  }
}