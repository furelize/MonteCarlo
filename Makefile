#!/bin/sh
cc=gcc
install:
	cc MonteCarlo.c -o montecarlo
	chmod +x montecarlo
clean:
uninstall:
	rm montecarlo
