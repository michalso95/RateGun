<template>
  <div class="view-container">
    <v-sheet elevation="10" color="dark" rounded width="80%" height="95%">
      <v-toolbar-title class="text-h2 ml-10 mt-5">News</v-toolbar-title>

      <div class="view-content">
        <div class="mt-10 ml-5">Here is content, so some news and so on</div>
        <div class="mt-10 ml-5">Here is content, so some news and so on</div>
        <div class="mt-10 ml-5">Here is content, so some news and so on</div>
        <div class="mt-10 ml-5">Here is content, so some news and so on</div>
        <div class="mt-10 ml-5">Here is content, so some news and so on</div>
        <div class="mt-10 ml-5">Here is content, so some news and so on</div>
        <div class="mt-10 ml-5">Here is content, so some news and so on</div>
        <div class="mt-10 ml-5">Here is content, so some news and so on</div>
      </div>
    </v-sheet>
  </div>
</template>

<script>
export default {
  name: "NewsView",

  data: () => ({
    //
  }),
};
</script>

<style scoped lang="scss">
.view-container {
  height: calc(100vh - 64px);
  max-height: calc(100vh - 64px);
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;

  .view-toolbar {
    width: 100%;
    flex: 0px;
    max-height: 75px;
    margin-top: 30px;
    margin-bottom: 30px;
    border: 1px solid white;
    padding: 10px;
  }

  .view-content {
    width: 100%;
    flex: 1;
    overflow: hidden;
    padding-top: 30px;
    padding-bottom: 30px;
    padding: 10px;
    min-height: calc(100vh - 64px);
    margin: auto;
  }
}
</style>
