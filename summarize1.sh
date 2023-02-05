#!/bin/bash

# Check if the required program is installed
if ! command -v curl > /dev/null || ! command -v awk > /dev/null; then
  echo "Error: curl or awk not found."
  echo "Please install curl and awk before running this script."
  exit 1
fi

# Check if the URL is provided
if [ $# -ne 1 ]; then
  echo "Usage: $0 URL"
  exit 1
fi

# Download the file from the URL
curl -s $1 | awk '
  # Split the text into sentences
  BEGIN { RS="[.?!]"; ORS="\n\n" }

  # Keep sentences that have more than 20 words
  { if (NF >= 20) { print } }
' | head -n 10
