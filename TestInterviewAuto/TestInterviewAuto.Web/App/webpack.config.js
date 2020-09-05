const path = require('path');

module.exports = {
  entry: './src/index.js',
  devtool: "source-map",
  output: {
    filename: 'bundle.js',
    path: path.resolve(__dirname, 'build')
  },
  module: {
    rules: [
        {
            test: /\.jsx$/,
            exclude: /(node_modules)/,
            use: {
                loader: 'babel-loader',
                options: {
                  presets: ["es2015", "stage-0", "react"]
                }
              }
        }
    ]
},
};