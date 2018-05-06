#include "reg52.h"  
#ifndef ds18b20_H
#define ds18b20_H

sbit DQ = P1^4;
sfr AUXR = 0x8e;

void Delay_OneWire(unsigned int t);
bit init_ds18b20();
void Write_DS18B20(unsigned char dat);
unsigned char Read_DS18B20();
//获取温度并返回
int read_temperature();

#endif