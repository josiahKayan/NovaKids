#include <MFRC522.h>
#include <SPI.h>
#include <Ethernet.h>

//Defines and Configurations
#define SS_PIN 53
#define RST_PIN 5
MFRC522 mfrc522(SS_PIN, RST_PIN);
byte mac[] = { 0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };
IPAddress server(192,168,0,12);  // numeric IP for Google (no DNS)
IPAddress ip(192, 168, 0, 178);
EthernetClient client;
//--------------------------------//

void setup() {
  Serial.begin(19200);
  SPI.begin();      // Inicia  SPI bus
  mfrc522.PCD_Init();   // Inicia MFRC522
 
  Serial.println();
  if (Ethernet.begin(mac) == 0) {
    Serial.println("Failed to configure Ethernet using DHCP");
    Ethernet.begin(mac, ip);
  }
}

void loop() {

mostraMensagem();
   // Look for new cards
  if ( ! mfrc522.PICC_IsNewCardPresent()) 
  {
    return;
  }
  // Select one of the cards
  if ( ! mfrc522.PICC_ReadCardSerial()) 
  {
    return;
  }


//Mostra UID na serial
  Serial.print("UID da tag :");
  String conteudo= "";
  byte letra;
  for (byte i = 0; i < mfrc522.uid.size; i++) 
  {
     Serial.print(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " ");
     Serial.print(mfrc522.uid.uidByte[i], HEX);
     conteudo.concat(String(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " "));
     conteudo.concat(String(mfrc522.uid.uidByte[i], HEX));
  }
  conteudo.toUpperCase();
  
if (conteudo.substring(1) == "CB 46 1D 2B"){
  
  configura();
  if (client.available()) {
    while(client.available()){
      char c = client.read();
      Serial.print(c);
    }
    delay(3000);
    client.stop();
  }
  if (!client.connected()) {
    Serial.println();
    Serial.println("disconnecting.");
    delay(2000);
    client.stop();
  }
}
}

void configura(){
  delay(5000);
  Serial.println("trying to connect...");

  if (client.connect(server, 8000)) {
    conecta();
  } else {
    Serial.println("connection failed");
  }
}

void conecta(){

    Serial.println("connected");
    delay(1000);
    String tag = "123";
    String url = "GET /php/index.php?tag=" + tag;
    client.println(url);
    delay(3000);
    client.println("Connection: close");
    client.println();

}

void mostraMensagem(){

  Serial.println("Aproxime o seu cartão!!!");

}

