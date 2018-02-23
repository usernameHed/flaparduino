/*
 * 
 */
 
// constants won't change. They're used here to set pin numbers:
const int buttonPin1 = 2;     // the number of the pushbutton pin
const int buttonPin2 = 3;     // the number of the pushbutton pin

// variables will change:
int buttonState1 = 0;         // variable for reading the pushbutton status
int buttonState2 = 0;         // variable for reading the pushbutton status

void setup()
{
  // initialize the pushbutton pin as an input:
  pinMode(buttonPin1, INPUT);
  // initialize the pushbutton pin as an input:
  pinMode(buttonPin2, INPUT);

  Serial.begin(9600);
}

void loop()
{
  // read the state of the pushbutton value:
  buttonState1 = digitalRead(buttonPin1);
  // read the state of the pushbutton value:
  buttonState2 = digitalRead(buttonPin2);

  // check if the pushbutton is pressed. If it is, the buttonState is HIGH:
  if (buttonState1 == HIGH)
  {
    Serial.println("1");
    //Serial.write(1);
    //Serial.flush();
    delay(20);
  }
  if (buttonState2 == HIGH)
  {
    Serial.println("2");
    //Serial.write(1);
    //Serial.flush();
    delay(20);
  }
  /*else
  {
    Serial.println("0");
    //Serial.write(2);
    //Serial.flush();
    delay(20);
  }*/
}
