# mylocation
## a demo for C# containers running in OpenShift.

Paired with locationms, this web site detects your IP address and your location. For use in demonstrating Kubernetes or OpenShift.

## Step 1. Create your project in OpenShift
It *must* be called 'test' for this demo.

`oc new-project test` at the command line

OR

Use the dashboard to create the new project 'test'.

## Step 2. Get the locationms service running in OpenShift

1. From the project home page, select "Deploy Image" option.
2. Image Name is: quay.io/donschenck/locationms:v2
3. Accept all of the warnings and defaults values and click the "Deploy" button.


## Step 3. Get the C# web site up and running

1. From the "Catalog" section of the left-hand menu, choose "Developer Catalog".
1. Select the ".NET Core" catalog.
1. Click "Create Application"
1. Select .NET Version 2.1.
1. Use "mylocation" (no quotes) as the name.
1. Use "https://github.com/donschenck/mylocation.git" as the Git Repository.
1. Select the "Create route" checkbox.
1. Click the "Create" button.


## View the results

1. Expand the "Networking" section of the left-hand menu.
1. Select "Routes".
1. Click on the route for the service "mylocation".
1. Explore the results.   

### If you get the "Application is not available" error, simply wait a minute or so and try again. The application is still being built and deployed.