#include <avr/io.h>
#include <stdlib.h>
uint8_t getp(uint8_t PORT);
uint8_t getpmax();
void delay(uint32_t ms);
uint8_t pumpen[3]={3,5,7};
int main(void)
{
    uint8_t i=0;
    DDRC=0x00;
    PORTC|=0b111111;    //PullUp Widerstand an den Pins der Signalgeber aktivieren
    DDRD=0b10011100;    //Pins der LED und der Pumpen als output
    PORTD|=(1<<PD6);    //PU Widerstand am Taster aktivieren
    uint8_t pmax;
    uint8_t pjetzt;
    uint8_t tasterjetzt=0;
    uint8_t tasterdavor=1;
    uint8_t eingeschaltet=0;
    while(1)
    {
        tasterjetzt=!(PIND&(1<<PD6));
        if(tasterjetzt&&!tasterdavor) //Flanke erkannt, Zustand des Systems umschalten
        {
            eingeschaltet^=1;
            PORTD^=(1<<PD7); //LED umschalten
        }
        tasterdavor=tasterjetzt;
        delay(10); //Entprellung
        if(eingeschaltet)
        {
            for(i=0;i<3;i++) //For Schleife zum ausschalten der Pumpen
            {
                if(PINC&(1<<2*i))
                    PORTD&=(~(1<<(i+2)));
            }
            pjetzt=getp(PORTD);
            pmax=getpmax();

            for(i=0;i<3;i++) //For Schleife zum einschalten der Pumpen
            {
                if((PINC&1<<(2*i+1))&&(pmax-pjetzt)>=pumpen[i])
                //Schließer=1 und Leistung der Pumpe würde die PMAX nicht überschreiten
                    PORTD|=(1<<(i+2));
            }
        }
        else
        {
            PORTD&=~(0b111<<2);
        }
    }
    return 0;
}
uint8_t getp(uint8_t PORT) //gibt die aktuelle Leistung der Pumpen zurück
{
    uint8_t i;
    uint8_t pjetzt=0;
    for(i=0;i<3;i++)
    {
        if(PORT&(1<<(i+2)))
            pjetzt+=pumpen[i]; //Leistung der eingeschalteten Pumpe addieren
    }
    return pjetzt;
}
uint8_t getpmax() //liest den Trimmer aus und gibt die Maximalleistung des Systems zurück
{
    ADMUX=0x47;
    ADCSRA|=0x07;
    ADCSRA|=(1<<ADEN);
    ADCSRA|=(1<<ADSC);
    while(ADCSRA&(1<<ADSC));
    return ADC/1023.0*15.0;
}
void delay(uint32_t ms)
{
    ms*=371;
    while(ms--);
}
