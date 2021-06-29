### dotNetCore5_REST_API
* build web api in c# with asp.net core 5 REST api

### SetUp
1. add local database name in appsettings.json
`"DBConnection": "server=(localdb)\\MSSQLLocalDB;database={DB_NAME_HERE};Trusted_Connection=true"`
2. PM> `Add-migration {migration_name}`
3. PM> `Update-database`

### Test
| URI | HTTP Verb | Outcome
| ----------- | ----------- | ----------- |
| ...api/employees | GET  | Gets list of employees |
| ...api/employees/1 | GET  | Gets employees with Id = 1 |
| ...api/employees | POST  | Creates a new employee |
| ...api/employees/1 | DELETE  | Deletes employee with Id = 1 |
| ...api/employees/1 | PUT or PATCH  | Updates employees with Id = 1 |

* `PUT` `Updates the entire object`
* `Patch` `Partial update - only a subset of the porperties`
