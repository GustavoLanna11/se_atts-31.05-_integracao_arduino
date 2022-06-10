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
    digitalWrite(led, HIGH);
    digitalWrite(led2, HIGH);
  }
}
