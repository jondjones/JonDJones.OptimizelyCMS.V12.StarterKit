docker run 
-d 
-p 8081:80 
--mount type=bind,source="$(pwd)/Cms/App_Data",destination=/app/App_Data 
--name cms12 
opti12starterkit 
--env ASPNETCORE_ENVIRONMENT=Docker



// Create the image
docker build -t opti12starterkit .

// Create the container
docker run -d -p 808`:80 --mount type=bind,source="$(pwd)/Cms/App_Data",destination=/app/App_Data --name cms12 opti12starterkit --env ASPNETCORE_ENVIRONMENT=Docker