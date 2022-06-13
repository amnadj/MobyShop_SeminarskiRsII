import 'package:flutter/material.dart';
import 'package:progress_dialog/progress_dialog.dart';

import '../services/payment.dart';

class Payment extends StatefulWidget {
  Payment({Key? key}) : super(key: key);

  @override
  PaymentState createState() => PaymentState();
}

class PaymentState extends State<Payment> {
  BuildContext? scaffoldContext;
  onItemPress(BuildContext context, int index) async {
    switch (index) {
      case 0:
        payViaNewCard(context);
        break;
      case 1:
        Navigator.pushNamed(context, '/cards');
        break;
    }
  }

  payViaNewCard(BuildContext context) async {
    ProgressDialog dialog = new ProgressDialog(context);
    dialog.style(message: 'Please wait...');
    await dialog.show();
    var response = await StripeService.payWithNewCard(amount: '15000', currency: 'USD');
    await dialog.hide();
    ScaffoldMessenger.of(context).showSnackBar(SnackBar(
      content: Text(response.message as String),
      duration: new Duration(milliseconds: response.success == true ? 1200 : 3000),
    ));
  }

  @override
  void initState() {
    super.initState();
    StripeService.init();
  }

  @override
  Widget build(BuildContext context) {
    ThemeData theme = Theme.of(context);
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.blueGrey,
        title: Text('SELECT PAYMENT'),
      ),
      body: Container(
        padding: EdgeInsets.all(20),
        child: ListView.separated(
            itemBuilder: (context, index) {

              Icon icon = Icon(Icons.access_time, color: Colors.blueGrey,);
              Text text = Text('test');
              
              switch (index) {
                case 0:
                 icon = Icon(Icons.add_circle, color: Colors.blueGrey);
                 text = Text('Pay via new card');
                  break;
                case 1:
                  icon = Icon(Icons.credit_card, color: Colors.blueGrey);
                  text = Text('Pay via existing card');
                  break;
              }

              return InkWell(
                onTap: () {
                  onItemPress(context, index);
                },
                child: ListTile(
                  title: text,
                  leading: icon,
                ),
              );
            },
            separatorBuilder: (context, index) => Divider(
              color: Colors.blueGrey,
            ),
            itemCount: 2),
      ),
    );
  }
}