<h1 align="center">Dexter</h1>
<h5 align="center">Pokemon search made with F# and Elmish</h5>
<a href="https://github.com/rajatsharma/dexter"><img src="demo.png" alt="dexter-demo"></a>

## Prerequisites

- [`dotnet sdk`](https://dotnet.microsoft.com/download)
- [`node`](https://nodejs.org/en/)
- [`yarn`](https://yarnpkg.com/)

## Getting Started

- Clone the repo.

```sh
git clone https://github.com/rajatsharma/dexter
```

- Install dependencies.

```sh
yarn
dotnet paket update
```

## Development

- Start development server with hot reload.

```sh
yarn dev
```

- Open [http://localhost:4500/](http://localhost:4500/)

## Deployment

- Create production build.

```sh
yarn build
```

- Dexter uses netlify-cli to deploy to [Netlify](https://www.netlify.com/).

```
yarn deploy
```

- You can also dry run deploys using 

```
yarn deploy:dry
```

[![Netlify Status](https://api.netlify.com/api/v1/badges/a5f928bb-b883-4d2a-9aae-125c67fbc967/deploy-status)](https://app.netlify.com/sites/doppler/deploys)
