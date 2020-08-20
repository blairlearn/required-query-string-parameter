# Required query string parameter

An answer to the question:
> Why isn't there an easy way to set required query parameters? Doesn't seem like an infrequently-used thing.

`dotnet run`

browse to | status | return
 --- | --- | ---
`http://localhost:5000/doohickey/WithParams` | 400 | `{"Required":["A value for the 'Required' property was not provided."]}`
`http://localhost:5000/doohickey/WithParams?Required=foo` | 200 | `["Required: foo","Optional: not set"]`
`http://localhost:5000/doohickey/WithParams?Required=foo&Optional=bar` | 200 | `["Required: foo","Optional: bar"]`
