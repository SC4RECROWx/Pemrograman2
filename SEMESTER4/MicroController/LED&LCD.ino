#include <LiquidCrystal.h>
#define BUTTON1 A0
#define BUTTON2 A1
#define LED13  13
#define LED3  3
#define PIN_RS  12
#define PIN_E  11
#define PIN_DB4  7
#define PIN_DB5  6
#define PIN_DB6  5
#define PIN_DB7  4

LiquidCrystal lcd(PIN_RS, PIN_E, PIN_DB4, PIN_DB5, PIN_DB6, PIN_DB7);

void setup() {
  // put your setup code here, to run once:
  lcd.begin(16, 2);
  pinMode(LED13, OUTPUT);
  pinMode(LED3, OUTPUT);

}

void loop() {
  // put your main code here, to run repeatedly:
  if(!digitalRead(BUTTON1) && digitalRead(BUTTON2)){
    lcd.setCursor(0,0);
    lcd.print("LED 1 Nyala            ");
    digitalWrite(LED13, HIGH);
    digitalWrite(LED3, LOW);
  }else if(digitalRead(BUTTON1) && !digitalRead(BUTTON2)){
    lcd.setCursor(0,0);
    lcd.print("LED 2 Nyala             ");
    digitalWrite(LED13, LOW);
    digitalWrite(LED3, HIGH);
  }else if(!digitalRead(BUTTON1) && !digitalRead(BUTTON2)){
    lcd.setCursor(0,0);
    lcd.print("LED ON                  ");
    digitalWrite(LED13, HIGH);
    digitalWrite(LED3, HIGH);
  }else if(digitalRead(BUTTON1) && digitalRead(BUTTON2)){
    lcd.setCursor(0,0);
    lcd.print("LED OFF                  ");
    digitalWrite(LED13, LOW);
    digitalWrite(LED3, LOW);
  }

}
