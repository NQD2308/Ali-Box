#include <Servo.h>

//========== EAR-EYES ==========
int trig_pin = A1;
int echo_pin = A2;

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

void setup() {
  Serial.begin(9600);
  servo_ear_left.attach(2);
  servo_ear_right.attach(3);
  servo_eyes.attach(4);

  pinMode(trig_pin, OUTPUT);
  pinMode(echo_pin, INPUT);

}

#define STATE_OPEN 0
#define STATE_CLOSED 1

void loop() {
  
  static bool is_open = true;
  static int state = STATE_OPEN;

  // int value_A0 = analogRead(cbRung_A0);

  if (state == STATE_CLOSED) {
    delay(2000);
    servo_ear_left.writeMicroseconds(ear_left_middle);
    servo_ear_right.writeMicroseconds(ear_right_middle);
    delay(500);
    state = STATE_OPEN;
  }
  else if (state == STATE_OPEN) {

    int distance = getDistance();
    
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
      delay(200);
      servo_ear_left.writeMicroseconds(ear_left_open);
      servo_ear_right.writeMicroseconds(ear_right_open);
    }
    else if (distance < 15 && distance > 7) {
      Serial.println("distance < 15 && distance > 7");    
      servo_ear_left.writeMicroseconds(ear_left_closed);
      servo_ear_right.writeMicroseconds(ear_right_closed);
      delay(200);
      servo_eyes.writeMicroseconds(servo_eyes_up);
      state = STATE_CLOSED;
    }
  }
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
