<h1 align="center">Dexter</h1>
<h5 align="center">Pokemon search made with F# and Elmish</h5>
<a href="https://github.com/rajatsharma/dexter"><img src="demo.png" alt="dexter-demo"></a>

[![Netlify Status](https://api.netlify.com/api/v1/badges/9c9cdce5-9faa-40ea-82b6-a184c6c60ca0/deploy-status)](https://dex-fs.netlify.app)

## Prerequisites

- [`dotnet sdk`](https://dotnet.microsoft.com/download)
- [`node`](https://nodejs.org/en/)
- [`yarn`](https://yarnpkg.com/)

## Getting Started

- Clone the repo.

```sh
$ git clone https://github.com/rajatsharma/dexter
```

- Install dependencies.

```sh
$ yarn
$ dotnet paket update
```

## Development

- Start development server with hot reload.

```sh
$ yarn dev
```

- Open [http://localhost:4500/](http://localhost:4500/)

## Deployment

- Create production build.

```sh
$ yarn build
```

- Dexter uses netlify-cli to deploy to [Netlify](https://www.netlify.com/).

```
$ yarn deploy
```

- You can also dry run deploys using 

```
$ yarn deploy:dry
```

## License

[![MIT](https://img.shields.io/badge/-MIT-black?style=flat-square)](https://github.com/rajatsharma/dexter/blob/master/LICENSE)
