#include "../Headerfunktionen/UART.h"
//#include "lcd.h"
#include <avr/io.h>
#include <avr/interrupt.h>
#include <string.h>

 char koordx[5];
 char koordy[5];
ISR(USART_RX_vect)
{
    uint8_t sreg=SREG;
    SREG&=~(1<<7);
    if(UDR0==49)
    {

//        lcd_clrscr();
//        lcd_puts(koordx);
        _puts(koordx);
        _puts(koordy);
        _newline();

    }
    SREG=sreg;
}
int main(void)
{
    uint8_t x;
    uint8_t y;
    ADCSRA|=0x07;
    ADCSRA|=(1<<ADEN);
    ADMUX|=0x60;
    SREG|=(1<<7);
//    lcd_init(LCD_DISP_ON);
//    lcd_clrscr();
    init_usart(57600);
    while(1)
    {
        ADMUX|=1;
        ADCSRA|=(1<<ADSC);
        while(ADCSRA&(1<<ADSC));
        x=ADCH;
        itoa8(x,koordx);
        ADMUX&=~1;
        ADCSRA|=(1<<ADSC);
        while(ADCSRA&(1<<ADSC));
        y=ADCH;
        itoa8(y,koordy);

    }
    return 0;
}
