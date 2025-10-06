#!/bin/sh
build:
	dotnet publish
	cp bin/Release/net9.0/publish/* .
clean:
run:
	dotnet run
uninstall:
	rm -rf obj/ bin/
