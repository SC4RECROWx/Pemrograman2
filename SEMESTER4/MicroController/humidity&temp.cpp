#include <DHT.h>;
#include <LiquidCrystal_I2C.h>
#include <Wire.h> 
#include <WiFi.h>
#include <PubSubClient.h>

#define DHTPIN 15   
#define DHTTYPE DHT22   // DHT 22  (AM2302)
DHT dht(DHTPIN, DHTTYPE); 

LiquidCrystal_I2C lcd(0x27,16,2);

char clientId[50];
WiFiClient wifiClient;  // Membuat objek wifiClient
PubSubClient mqttClient(wifiClient);  // Membuat Object mqttClient dengan Konstruktor objek WiFiClient (Permintaan dari Lib)

char *mqttServer = "broker.hivemq.com";
//String mqttServer = "broker.hivemq.com";   //opsi kedua selain char
int mqttPort = 1883;

void callback(char* topic, byte* message, unsigned int length){
  Serial.print("CallBack - ");
  Serial.print("Message: ");
  for(int i = 0; i < length; i++){
    Serial.print((char)message[i]);
  }
}

void reconnect(){
  WiFi.mode(WIFI_STA);  // Assign esp as Station
  WiFi.begin("Wokwi-GUEST", "");
  while(WiFi.status()!=WL_CONNECTED){
    Serial.println(".");
    delay(100);
  }
  Serial.print("Status Koneksi : ESP Telah Terkoneksi");
  //Serial.println(WiFi.status());
  //Serial.println("ESP Telah Terkoneksi");
}

void connectToBroker() {
  Serial.println("Connecting to MQTT Broker...");
  while (!mqttClient.connected()) {
      Serial.println("Reconnecting to MQTT Broker..");
      String clientId = "ESP32Client-";
      clientId += String(random(0xffff), HEX);
      
      if (mqttClient.connect(clientId.c_str())) {
        Serial.println("Connected.");
      }      
  }
}

void setup()
{ 
  lcd.init();
  Serial.begin(115200);
  Serial.println("Starting....");
  reconnect();
  dht.begin();
  mqttClient.setServer(mqttServer, mqttPort);  // Mengatur detail Broker target yang digunakan
  mqttClient.setCallback(callback);            // Jika kita ingin menerima persan untuk langganan yang dibuat oleh client
  connectToBroker();
  lcd.backlight();
  lcd.setBacklight(HIGH);
  lcd.setCursor(0,0);
  lcd.println("Hello Im");
  lcd.setCursor(0,1);
  lcd.println("Nur Akbar");
  delay(1000);
}

void loop()
{
  
    double humidity = dht.readHumidity();
    double temperature = dht.readTemperature();

    lcd.setCursor(0,0);
    lcd.println("Humid :");
    lcd.println(humidity);
    lcd.println("%");
    lcd.setCursor(0,1);
    lcd.println("Temp :"); 
    lcd.println(temperature);
    lcd.println("C");
   
    Serial.print("Humidity : ");
    Serial.print(humidity);
    Serial.print(" %, Temperature : ");
    Serial.print(temperature);
    Serial.println(" Celsius");

    char humString[8];
    dtostrf(humidity,1,1,humString); // Convert float to String
    mqttClient.publish("techad/test/tes1", humString);

    char tempString[8];
    dtostrf(temperature,1,1,tempString); // Convert float to String
    mqttClient.publish("techad/test/tes1", tempString);

    //delay(10000); 
    delay(1000);
}
