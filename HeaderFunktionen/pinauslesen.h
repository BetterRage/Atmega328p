#ifndef PINAUSLESEN_H_INCLUDED
#define PINAUSLESEN_H_INCLUDED
#include <avr/io.h>
uint8_t pinlesen(uint8_t pin)
{
    if(!(PINC&1<<pin))
       return 1;
    else
        return 0;
}
uint8_t analoglesen8(uint8_t pin)
{
    ADCSRA|=0x07;
    ADCSRA|=(1<<ADEN);
    ADMUX|=0x60;
    ADMUX|=pin;
    ADCSRA|=(1<<ADSC);
    while(ADCSRA&(1<<ADSC));
    return ADCH;
}
uint16_t analoglesen16(uint8_t pin)
{
    ADCSRA|=0x07;
    ADCSRA|=(1<<ADEN);
    ADMUX|=0x40;
    ADMUX|=pin;
    ADCSRA|=(1<<ADSC);
    while(ADCSRA&(1<<ADSC));
    return ADC;
}
#endif // PINAUSLESEN_H_INCLUDED
