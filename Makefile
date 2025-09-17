#!/bin/sh
cc = gcc
install:
	test -f config.h || cp config.def.h config.h
	cc MonteCarlo.c -lncurses
	mv a.out montecarlo
	chmod +x montecarlo
clean:
uninstall:
	rm montecarlo
