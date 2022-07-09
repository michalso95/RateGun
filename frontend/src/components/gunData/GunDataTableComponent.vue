<template>
  <div class="mx-auto dataStyle">
    <h2>{{title}}</h2>
    <v-simple-table dark>
      <template v-slot:default>
        <thead>
          <tr>
            <th>
            </th>
            <th>
            </th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="keyValue in tableData" :key="keyValue.key">
            <td class="text-left" width="50%">{{ keyValue.key }}</td>
            <td class="text-left" width="50%">{{ keyValue.value }}</td>
          </tr>
        </tbody>
      </template>
    </v-simple-table>
  </div>
</template>

<script lang="js">

export default {
  name: 'GunDataTableComponent',

  props: {
    tableData: Array,
    title: String
  }

}
</script>

