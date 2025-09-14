#include <math.h>
#include <stdio.h>
#include "config.h"
#include <stdbool.h>
#include <ncurses.h>
#include <stdlib.h>

int main() {
	printf("Welcome to the simulator\n");
	printf("Do you want to use modern terminal mode or legacy gui mode, yes or no?\n")
	char userchoiceinter[100];
	fgets(userchoicegui, 10, stdin);
	switch (userchoicegui) {
		case (strcmp(userchoiceinter, yes)==0:
			guiinterface()
			break:
		case (strcmp(userchoiceguinter, no)==0:
			terminalinterface()
			break:
		default:
		printf("please give a valid response");
	}
}
void guiinterface() {
}
void terminainterface() {
}
