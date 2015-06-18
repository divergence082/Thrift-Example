#!/usr/bin/env bash

# LANG = csharp | java | py | php
# ./generate.sh ${LANG}

LANG=$1
DIR=./code/$LANG

rm -rf $DIR && mkdir -p $DIR
thrift -r -strict --gen $LANG -out $DIR idl/dialog-service.thrift
