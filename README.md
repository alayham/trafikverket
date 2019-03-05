# Trafikverket .Net client library

This is a work in progress to build a .Net library for Trafikverket Open Data API.

Currently, only train data is supported.

## Getting Started

### Prerequisites

You need a trafikverket api key. get one from https://api.trafikinfo.trafikverket.se/Account/Register

### Getting started
Reference the project in your app, then create a global static instance of the client class

```
        private static TrafikVerketClient Client = new TrafikVerketClient(myKey);
```
you can extend the client and its classes with your own methods and queries.

## Running the tests

The library will be fully unit-tested, however this is still a work in progress.

currently you can run the accompanied client app to test some of the basic functionalities of the library.

## To Do
- Unit tests for the library
- add more trafikverket open data objects and queries.
- A windows client App to show case the potentials of the library.

## Contributing

Please submit bugs and feature requests via github.

Pull requests are welcome.

## Versioning

This is still a development version

## Authors

* **Al Saleh**  - [personal site](https://alayham.com)

## License

This project is currently licensed under the GPL version 2 license, the licensing might change at a later point.

