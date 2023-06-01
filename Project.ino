#include"SoftwareSerial.h"
#include "DFRobotDFPlayerMini.h"
#include <Servo.h>

//=============== MP3 ===============
SoftwareSerial mySoftwareSerial(10,11);
DFRobotDFPlayerMini myDFPlayer;
void printDetail(uint8_t type, int value);
//===================================


//============ MH Sensor ============
const int cbRung_A0 = A0;
//===================================


//============= HC-SRO4 =============
int trig_pin = A1;
int echo_pin = A2;
//===================================


//============== Servo ==============
Servo servo_ear_left;
Servo servo_ear_right;
Servo servo_eyes;

int ear_left_open = 1100;
int ear_left_middle = 1500;
int ear_left_closed = 2100;
int ear_right_open = 1900;
int ear_right_middle = 1500;
int ear_right_closed = 1100;

int servo_eyes_up = 1300;
int servo_eyes_normal = 1500;
//===================================


void setup() {
  mySoftwareSerial.begin(9600);
  Serial.begin(115200);
  
  if(!myDFPlayer.begin(mySoftwareSerial))
  {
    Serial.println(F("Không thể khởi động"));
    Serial.println(F("1. Kiểm tra lại kết nối"));
    Serial.println(F("2. Lắp lại thẻ nhớ"));
    while(true)
    {
      delay(0);
    }
  }
  Serial.println(F("DFPlayer đang hoạt động"));
  myDFPlayer.volume(30);

  servo_ear_left.attach(2);
  servo_ear_right.attach(3);
  servo_eyes.attach(4);

  pinMode(cbRung_A0, INPUT); 
  pinMode(trig_pin, OUTPUT);
  pinMode(echo_pin, INPUT);  
}

#define STATE_OPEN 0
#define STATE_CLOSED 1

void loop() {
  
  //============= ACTION =============
  static bool is_open = true;
  static int state = STATE_OPEN;
  
  if (state == STATE_CLOSED) {
    delay(2000);
    servo_ear_left.writeMicroseconds(ear_left_middle);
    servo_ear_right.writeMicroseconds(ear_right_middle);
    delay(500);
    state = STATE_OPEN;
  }
  else if (state == STATE_OPEN) {

    int distance = getDistance();
    // Serial.print("Distance: ");
    Serial.println(distance);
    
    if (distance >= 30) {
      Serial.println("distance >= 30"); 
      servo_eyes.writeMicroseconds(servo_eyes_normal);
      delay(200);
      servo_ear_left.writeMicroseconds(ear_left_open);
      servo_ear_right.writeMicroseconds(ear_right_open);
    }
    else if (distance < 30 && distance >= 15) {
      Serial.println("distance < 30 && distance >= 15"); 
      servo_eyes.writeMicroseconds(servo_eyes_up);
      servo_ear_left.writeMicroseconds(ear_left_open);
      servo_ear_right.writeMicroseconds(ear_right_open);
      myDFPlayer.playMp3Folder(1);
      delay(3000);   
    }
    else if (distance < 15 && distance > 7)
     {
      Serial.println("distance < 15 && distance > 7");    
      servo_ear_left.writeMicroseconds(ear_left_closed);
      servo_ear_right.writeMicroseconds(ear_right_closed);
      servo_eyes.writeMicroseconds(servo_eyes_up);
      // myDFPlayer.playMp3Folder(1);
      // delay(3000);
      delay(200);
      
      state = STATE_CLOSED;
    }
  }
  

  //============ MH Sensor ============
  int value_A0 = analogRead(cbRung_A0);
  
  Serial.print("Analog: ");
  Serial.println(value_A0);

  if(value_A0 < 1000 && value_A0 >= 600)
  {
    // Serial.println("Heyyy!Don't shake me :(((");
    // myDFPlayer.playMp3Folder(4);
    // delay(2800);  
  }
  else if(value_A0 < 600 && value_A0 >= 200)
  {
    // Serial.println("Don't shake me, pleaseeee :(((");
    myDFPlayer.playMp3Folder(3);
    delay(4500);  
  }

  if(value_A0 < 200)
  {
    // Serial.println("I'm so dizzy");
    myDFPlayer.playMp3Folder(5);
    delay(3000);    
  }
  else
  // Serial.println("");     
  delay(200);
}

float getDistance() {
  digitalWrite(trig_pin, LOW);
  delayMicroseconds(2);
  digitalWrite(trig_pin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trig_pin, LOW);
  unsigned long duration = pulseIn(echo_pin, HIGH);
  float distance = duration / 29.0 / 2.0;

  return distance;
}
