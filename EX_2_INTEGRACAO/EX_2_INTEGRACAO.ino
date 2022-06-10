int led=10;
int led2=9;
int led3=8;
int n=0;

void setup() {
  pinMode(led, OUTPUT);
  Serial.begin(9600);
  pinMode(led2, OUTPUT);
  Serial.begin(9600);
  pinMode(led3, OUTPUT);
  Serial.begin(9600);

}

void loop() {
  n=Serial.read();

  if(n=='L')
  {
    digitalWrite(led3, HIGH);
    delay(200);
    digitalWrite(led2, HIGH);
    delay(200);
    digitalWrite(led, HIGH);
    delay(200);

    delay(1000);
  }

  else if(n=='D')
  {
    digitalWrite(led, LOW);
    delay(200);
    digitalWrite(led2, LOW);
    delay(200);
    digitalWrite(led3, LOW);
    delay(200);

    delay(1000);
  }

}
