#define green1 0
#define yellow1 1
#define red1 2
#define green 3
#define yellow 4
#define red 5



void setup() {
  // put your setup code here, to run once:
    pinMode(green1, OUTPUT);
    pinMode(red1, OUTPUT);
    pinMode(yellow1, OUTPUT);
    pinMode(green, OUTPUT);
    pinMode(red, OUTPUT);
    pinMode(yellow, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  
  
  digitalWrite(green1, HIGH);
  digitalWrite(red, HIGH);
  delay(1000);
  digitalWrite(green1, LOW);
  digitalWrite(red, LOW);

 
  digitalWrite(yellow1, HIGH);
  digitalWrite(yellow, HIGH);
  delay(1000);
  digitalWrite(yellow1, LOW);
  digitalWrite(yellow, LOW);

  
  digitalWrite(red1, HIGH);
  digitalWrite(green, HIGH);
  delay(1000);
  digitalWrite(red1, LOW);
  digitalWrite(green, LOW);
}
