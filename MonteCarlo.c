#include <stdio.h>
#include <stdbool.h>
#include <ncurses.h>
#include <stdlib.h>
#include <string.h>


int guiinterface() {
	initscr();
	printw("Welcome to the gui version of the simulator!\n");
	printw("Please enter the directory of the data ");
	refresh();
	getch();
	endwin();
	return 110;
}
int terminalinterface() {
	printf("please enter the directory of the data ");
	char simdirectory[200];
	fgets(simdirectory, 200, stdin);
	return 0;
}
int main() {
	printf("Welcome to the simulator\n");
	printf("Do you want to use modern ter mode or legacy gui?\n");
	char userchoiceinterface[10];
	fgets(userchoiceinterface, 4, stdin); 	
	while (1) {
		if ((strcmp(userchoiceinterface,"gui") !=  0) && (strcmp(userchoiceinterface,"ter") != 0 )) {
			strcpy(userchoiceinterface,"");
			printf("please give an valid response ");
			fgets(userchoiceinterface, 4, stdin);
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
