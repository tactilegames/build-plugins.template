#!/bin/bash

SCRIPT_DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )"
cd "$SCRIPT_DIR"

echo "$SCRIPT_DIR"

# Set the locale variables for sed compatibility
export LC_ALL=C
export LANG=C

verbose=0
if [[ "$1" == "--verbose" ]]; then
  verbose=1
fi

echo ""
echo ""
echo "---------------------"
echo "Name your new plugin"
echo "---------------------"

# Get the plugin name from the user
echo "- Enter the new Build Plugin name:"
echo "(Note: avoid using any suffix, the tool will take care of that.)"
read plugin_name

if [[ $verbose -eq 1 ]]; then
  echo "---------------------"
  echo "Renaming Directories"
  echo "---------------------"
fi

# 1. Change directory names from inner to outer
find . -type d -name '*PLUGIN_NAME*' -not -path '*/.git/*' | while read dir; do
  new_dir=$(echo "$dir" | sed "s/PLUGIN_NAME/$plugin_name/g")
  mv "$dir" "$new_dir"
  if [[ $verbose -eq 1 ]]; then
    echo "Moved directory $dir to $new_dir"
  fi
done

if [[ $verbose -eq 1 ]]; then
  echo "------------------------"
  echo "Replacing files content"
  echo "------------------------"
fi

# 2. Replace PLUGIN_NAME in all files (except this script) recursively under the parent folder
find . -type f ! -name "$(basename $0)" -not -path '*/.git/*' -exec grep -l 'PLUGIN_NAME' {} \; | while read file; do
  sed -i '' "s/PLUGIN_NAME/$plugin_name/g" "$file"
  if [[ $verbose -eq 1 ]]; then
    echo "Replaced PLUGIN_NAME with $plugin_name in $file"
  fi
done

if [[ $verbose -eq 1 ]]; then
  echo "------------------------"
  echo "Renaming files name"
  echo "------------------------"
fi

# 3. Change file names containing PLUGIN_NAME
find . -type f -name '*PLUGIN_NAME*' -not -path '*/.git/*' | while read file; do
  new_file=$(echo "$file" | sed "s/PLUGIN_NAME/$plugin_name/g")
  mv "$file" "$new_file"
  if [[ $verbose -eq 1 ]]; then
    echo "Renamed file $file to $new_file"
  fi
done

if [[ $verbose -eq 1 ]]; then
  echo "------------------------"
  echo "Renaming root folder"
  echo "------------------------"
fi

# 4. Rename the parent folder of the script
parent_folder_name=$(basename "$(pwd)")
cd ..
new_parent_folder_name=$(echo "$parent_folder_name" | sed "s/PLUGIN_NAME/$plugin_name/g")
mv "$parent_folder_name" "$new_parent_folder_name"

if [[ $verbose -eq 1 ]]; then
  echo "Renamed parent folder $parent_folder_name to $new_parent_folder_name"
files

rm "$new_parent_folder_name/setup.sh"
open "$new_parent_folder_name"

echo "------------------------"
echo "Enjoy coding!"
echo "------------------------"