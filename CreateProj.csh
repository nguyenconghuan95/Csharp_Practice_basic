#!/bin/csh

if ($#argv != 1) then
    echo "Please input only name of the Project"
    exit 1
endif

set proj_name = $argv[1]
cp -rf Base $proj_name

foreach file (`find $proj_name -name "Base*"`)
    set new_name = `echo $file | sed "s/Base/$proj_name/g"`
    mv $file $new_name
end

find $proj_name -type f -print0 | xargs -0 sed -i "s/Base/$proj_name/g"




