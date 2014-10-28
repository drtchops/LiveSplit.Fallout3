#!/bin/sh

VERSION=$1
if [ -z "$VERSION" ]; then
    echo "Must specify version."
    exit 1
fi

zip LiveSplit.Fallout3_v${VERSION}.zip LiveSplit.Fallout3.dll ../readme.txt
