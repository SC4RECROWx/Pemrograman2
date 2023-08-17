//menyalakan motor DC dengan arduino
//memanggil libraries LCD
#include <LiquidCrystal.h>

//memberikan inisialisasi pin led (sesuai pin yang digunakan)
int rs=8, en=9, d4=10, d5=11, d6=12, d7=13; //memberikan variabel dan memasukkan masing-masing PIN LCD
LiquidCrystal lcd(rs,en,d4,d5,d6,d7); //memasukkan nama masing-masing dari PIN LCD

//memberikan inisialisasi pin led (sesuai pin yang digunakan)
  int pinLedkiri=6; //variabel pinLed1 berada di pin 6
  int pinLedkanan=1; //variabel pinLed2 berada di pin 1

  int pinMotor1=4; //variabel pinMotor berada di pin 4
  int pinMotor2=2; //variabel pinMotor berada di pin 2

  int pinButtonStartStop=7; //variabe pinButton1 berada di pin 7
  int pinButtonkiri=5; //variabel pinButton2 berada di pin 5
  int pinButtonkanan=0; //variabel pinButton3 berada di pin 0


//inisialisasi nilai awal untuk semua button status dengan 0 (low)
  int buttonStatusStartStop = 0;
  int buttonStatusKiri = 0;
  int buttonStatusKanan = 0;
  
void setup() {
  // put your setup code here, to run once:
  //Mengaktifkan lcd sesuai dengan lcd yang kita gunakan karena disini saya menggunakan L293D dengan jumlah kolom 16, dan baris 2 (sesuai dengan lcd yang kita gunakan)
  lcd.begin(16,2);
//Set letak kursor lcd ke dalam kolom 0, baris 0
  lcd.setCursor(0,0);
//menampilkan pesan di posisi kursor (kolom 0, baris 0)
  lcd.print("SC4RECROWx");
//Set kursor lcd ke kolom 0, baris 1
  lcd.setCursor(0,1);
//menampilkan pesan di posisi kursor (kolom 0, baris 1)
  lcd.print("STATUS : ");

//Set pin led mode OUTPUT
  pinMode (pinLedkiri, OUTPUT); //sebagai Output
  pinMode (pinLedkanan, OUTPUT); //sebagai Output

//Set pin inputan motor mode OUTPUT
  pinMode (pinMotor1, OUTPUT); //sebagai Output
  pinMode (pinMotor2, OUTPUT); //sebagai Output

//Set pin button mode INPUT
  pinMode (pinButtonStartStop, INPUT); //sebagai inputan
  pinMode (pinButtonkiri, INPUT); //sebagai inputan
  pinMode (pinButtonkanan, INPUT); //sebagai inputan

//Set pin button dengan nilai HIGH sebagai default
  digitalWrite(pinButtonStartStop, HIGH);
  digitalWrite(pinButtonkiri, HIGH);
  digitalWrite(pinButtonkanan, HIGH);

}

void loop() {
  // put your main code here, to run repeatedly:
  //Membaca nilai pin button dan hasilnya dimasukkan ke variabel button status
  buttonStatusStartStop = digitalRead(pinButtonStartStop);
  buttonStatusKiri = digitalRead(pinButtonkiri);
  buttonStatusKanan = digitalRead(pinButtonkanan);
//Set kursor lcd ke kolom 10, baris 1 (setelah STATUS : )
  lcd.setCursor(10,1);
  if(buttonStatusStartStop == LOW)
  {
//keterangan jika tombol start/stop ditekan, maka pada LCD akan muncul tampilan START, serta putar kiri dan kanan diaktifkan
  lcd.print("START");
//kemudian set kursor LCD ke kolom 16, baris 1 setelah START
  lcd.setCursor(16,1); 
//keterangan  jika tombol putar kanan ditekan, maka tampil di LCD STATUS : START (PUTARAN KANAN), 
//bersamaan dengan itu lampu led kanan akan ikut menyala, dan Motor DC akan berputar ke arah kanan
   if(buttonStatusKiri == HIGH && buttonStatusKanan == LOW)
   {
   lcd.print("(PUTARAN KANAN) ");
   digitalWrite(pinLedkanan, HIGH);
   digitalWrite(pinLedkiri, LOW);
   digitalWrite(pinMotor1, HIGH);
   digitalWrite(pinMotor2, LOW);
   }
//keterangan  jika tombol putar kiri ditekan, maka tampil di LCD STATUS : START (PUTARAN KIRI), 
//bersamaan dengan itu lampu led kiri akan ikut menyala, dan Motor DC akan berputar ke arah kiri
   else if(buttonStatusKiri == LOW && buttonStatusKanan == HIGH)
   {
   lcd.print("(PUTARAN KIRI)    ");
   digitalWrite(pinLedkanan, LOW);
   digitalWrite(pinLedkiri, HIGH);
   digitalWrite(pinMotor1, LOW);
   digitalWrite(pinMotor2, HIGH);
   }
//keterangan jika tombol putar kiri dan tombol putar kanan ditekan, maka tampil di LCD STATUS : START (TIDAK BERPUTAR),  
//bersamaan dengan itu lampu led kiri dan kanan akan menyala, dan Motor DC tidak akan berputar karena nilai positif dan negatifnya sama, yaitu hight
   else if(buttonStatusKiri == LOW && buttonStatusKanan == LOW)
   {
   lcd.print("(TIDAK BERPUTAR)");
   digitalWrite(pinLedkanan, HIGH);
   digitalWrite(pinLedkiri, HIGH);
   digitalWrite(pinMotor1, HIGH);
   digitalWrite(pinMotor2, HIGH);
   }
//keterandan jika tombol putar kiri dan tombol putar kanan tidak ditekan, maka lampu led kiri dan led kanan tetap padam,  
//dan Motor DC tidak akan berputar karena nilai positif dan negatifnya sama, yaitu low. Maka LCD akan menampilkan STATUS : START (TIDAK BERPUTAR),
   else if(buttonStatusKiri == HIGH && buttonStatusKanan == HIGH)
   { 
   lcd.print("(TIDAK BERPUTAR) ");
   digitalWrite(pinLedkanan, LOW);
   digitalWrite(pinLedkiri, LOW);
   digitalWrite(pinMotor1, LOW);
   digitalWrite(pinMotor2, LOW);
   }
}
  else
  {
//keterangan jika tombol start/stop ditekan, maka LCD akan menampilkan STATUS : STOP,
//serta tombol putar kiri dan dan kanan ikut dinonaktifkan, lampu Led kiri dan Led kanan akan dan Motor DC otomatis berhenti berputar
  lcd.print("STOP                   ");
  buttonStatusKiri=false;
  buttonStatusKanan=false;
  buttonStatusKiri == HIGH;
  buttonStatusKanan == HIGH;
  digitalWrite(pinLedkanan, LOW);
  digitalWrite(pinLedkiri, LOW);
  digitalWrite(pinMotor1, LOW);
  digitalWrite(pinMotor2, LOW);
  }

}
