![Program](https://img.shields.io/badge/Program-Visual%20Studio-blueviolet)
![Langage](https://img.shields.io/badge/langage-C%23-brightgreen)
![License](https://img.shields.io/badge/license-MIT-green)

# BerclazMayITSM

This project was carried out as part of the "624-2 - Software Engineering" module for the IT Service Management (ITSM) course.

## Installation

Just unzip the zip and open the solution file (.sln) in Visual Studio.

## Usage

You can directly launch it from Visual Studio and the Windows Form should appear and be functionnal with the WCF Service.

## Datas available for test
### MSSQL - Table Person

| UID  | Username | Balance |
| ------------- | ------------- | ------------- |
| 1  | aurelien  | 75 |
| 2  | brice  | 100 |

Data status as at 24.05.2020. The data is subject to any changes made by the user or by the web service.


## Known bug
### No listening endpoint on localhost
#### Problem

An error may occur when executing an operation in Windows Form. The error is of type "No listening endpoint on localhost". A temporary solution was to simply remove the "ServiceReferencePayment" service from the connected services and add it again with exactly the same name to resolve this error. But it was a major bug and we found a better solution

#### Solution

The solution implemented is to set the WCF Service to start at the same time as the Windows Form. For that, the settings "Set startup projects" has been updated to choose multiple startup projects so now the WCF Service is running in background to make sur the connection to the webservice is available.


## License
[MIT](https://choosealicense.com/licenses/mit/)
