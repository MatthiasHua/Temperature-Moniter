#include "reg52.h"  
#include "ds18b20.h"

bit read_flag = 0;

void cls_buzz()
{
	P2 = (P2&0x1F|0xA0);
	P0 = 0x00;
	P2 &= 0x1F;
}


// ��ȡ�������룬���������Ҫ��ʱ�趨��־read_flagΪ1
void serial() interrupt 4 using 3 {
	unsigned char ch;
	if (RI){
		RI = 0 ;
		ch = SBUF;
		if (ch == ' ')
			read_flag = 1; 
	}
}

// ���ڳ�ʼ��
void init_uart() {  
		PCON &= 0x7F;      
		SCON = 0x50;          
		AUXR &= 0xBF;         
		AUXR &= 0xFE;        
		TMOD &= 0x0F;       
		TMOD |= 0x20;         
		TL1 = 0xFD;      
		TH1 = 0xFD;      
		ET1 = 0;          
		TR1 = 1;        
		EA = 1;
		ES = 1;
}  

// ���� ����һ���ֽ�
void Serial_Send_Char(unsigned char c) {
    SBUF = c;
    while(!TI);
		TI=0;
}

// ���� ����һ��16λ�޷�������
void Serial_Send_Integer(unsigned int num) {
		Serial_Send_Char(num / 256);
		Serial_Send_Char(num % 256);
}

// �ȴ����� �������ʱͨ�����ڷ����¶�
void run() {
	  int temperature = read_temperature();
	  if(read_flag == 1) {
		  	ES = 0;
        Serial_Send_Integer(temperature);
				ES = 1;
				read_flag = 0;
		}
}

void main() {		
    cls_buzz();
    init_uart();
    while(1)
		    run();
}
