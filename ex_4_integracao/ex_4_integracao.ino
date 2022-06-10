int led=10;
int led2=9;
int led3=8;
int n=0;
int nota;

void setup() {
  pinMode(led, OUTPUT);
  Serial.begin(9600);
  pinMode(led2, OUTPUT);
  pinMode(led3, OUTPUT);

}

void loop() {
   if(Serial.available())
   //Verificar porta serial

   nota=Serial.read();

   if(nota>'0' && nota<='5')
   {
    digitalWrite(led, HIGH);

    digitalWrite(led2, LOW);
    digitalWrite(led3, LOW);
    
   }

   else if(nota>'5' && nota<='7')
   {
    digitalWrite(led2, HIGH);

    digitalWrite(led3, LOW);
    digitalWrite(led, LOW);
   }

   else if(nota>'7' && nota<='10')
   {
    digitalWrite(led3, HIGH);
    
    digitalWrite(led2, LOW);
    digitalWrite(led, LOW);
   }

}
