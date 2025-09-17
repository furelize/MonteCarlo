#include <stdio.h>
#include <stdbool.h>
#include <ncurses.h>
#include <stdlib.h>
#include <string.h>
#include "ncurses.c"

int main() {
	printf("Welcome to the simulator\n");
	printf("Do you want to use modern ter mode or legacy gui?\n");
	char userchoiceinterface[4];
	fgets(userchoiceinterface, 4, stdin); 	
	while (1) {
		if ((strcmp(userchoiceinterface,"gui") !=  0) && (strcmp(userchoiceinterface,"ter") != 0 )) {
			strcpy(userchoiceinterface,"");
			printf("please give an valid response ");
			fgets(userchoiceinterface, 4, stdin);
			userchoiceinterface[4]='\0';
	} else {
		break;
	}
	}
	if (strcmp(userchoiceinterface,"gui") == 0) {
		guiinterface();
	} else {
		terminalinterface();
	}
}
