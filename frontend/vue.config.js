module.exports = {
  chainWebpack: config => config.resolve.symlinks(false),
  devServer: {
    port: 8190
  }

}