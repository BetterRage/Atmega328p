/*
 */
#include "lcd.h"
#include <avr/io.h>
#include <util/delay.h>
int main(void)
{

    lcd_init(LCD_DISP_ON);
    lcd_clrscr();
    while(1)
    {
        lcd_clrscr();
        lcd_puts("1");
    }


    return 0;
}
