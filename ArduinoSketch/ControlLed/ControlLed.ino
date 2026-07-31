const int LED_PIN = LED_BUILTIN;

void setup() {
  Serial.begin(9600);
  pinMode(LED_PIN, OUTPUT);
  digitalWrite(LED_PIN, LOW);
}

void loop() {
  if (Serial.available() > 0) {
    char comando = Serial.read();

    if (comando == '1') {
      digitalWrite(LED_PIN, HIGH);
    } else if (comando == '0') {
      digitalWrite(LED_PIN, LOW);
    }
  }
}
