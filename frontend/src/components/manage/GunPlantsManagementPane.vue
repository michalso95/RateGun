<template>
  <div class="gunPlantsManagement">
    <div class="gunPlantsManagement-form">
      <div class="mt-5">
        <div class="gunPlantsManagement-header">
          <h2>All GunPlants</h2>
          <div>
            <v-btn @click.prevent="addGunPlantDialog = true" color="accent">
              <v-icon class="margin-right-small">mdi-plus-circle</v-icon>
              Add GunPlants
            </v-btn>
          </div>
        </div>
        <div class="d-flex">
          <v-row>
            <v-col>
            </v-col>
            <v-spacer></v-spacer>
            <v-col class="d-flex">
              <v-icon>mdi-magnify</v-icon>
              <v-text-field
                v-model="searchField"
                label="Start typing"
                clearable
              >
              </v-text-field>
            </v-col>
          </v-row>
        </div>
        <v-simple-table>
          <template v-slot:default>
            <thead>
              <tr>
                <th class="text-left">GunPlant name</th>
                <th class="text-left">Country</th>
                <th class="text-left">Location</th>
                <th class="text-left"></th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="gunPlant in gunPlantsList" :key="gunPlant.id">
                <td>{{ gunPlant.name }}</td>
                <td>{{ gunPlant.country }}</td>
                <td>{{ gunPlant.location }}</td>
                <td align="right">
                  <div class="my-auto">
                    <v-btn icon @click.prevent="editGunPlant(gunPlant)">
                      <v-icon>mdi-pencil</v-icon>
                    </v-btn>
                    <v-btn icon @click.prevent="removeGunPlant(gunPlant)">
                      <v-icon>mdi-delete</v-icon>
                    </v-btn>
                  </div>
                </td>
              </tr>
            </tbody>
          </template>
        </v-simple-table>
      </div>
    </div>
    <v-dialog v-model="addGunPlantDialog" max-width="500" persistent>
      <AddGunPlantForm
        v-if="addGunPlantDialog"
        @closeDialog="addGunPlantDialog = false"
      />
    </v-dialog>
    <v-dialog v-model="editGunPlantDialog" max-width="500" persistent>
      <EditGunPlantForm
        v-if="editGunPlantDialog"
        :gunPlant="editedGunPlant"
        @closeDialog="editGunPlantialog = false"
      />
    </v-dialog>
  </div>
</template>

<script lang="js">

import AddGunPlantForm from "./forms/AddGunPlantForm";
import EditGunPlantForm from "./forms/EditGunPlantForm";
import { mapState } from "vuex";
import { REMOVE_GUN_PLANT } from "@/store/actions";

export default {
  name: "GunPlantsManagementPane",
  components: {
    AddGunPlantForm,
    EditGunPlantForm,
  },
  data() {
    return {
      addGunPlantDialog: false,
      editGunPlantDialog: false,
      editedGunPlant: undefined,
      searchField: '',
    };
  },
  computed: {
    ...mapState({
      state: (state) => {
        return state;
      },
    }),
    gunPlantsList() {
      return []; //.filter(x=> x.model.toLowerCase().startsWith(this.searchField.toLowerCase()));
    }
  },
  methods: {
    async removeGunPlant(gunPlant) {
      this.$store.dispatch(REMOVE_GUN_PLANT, gunPlant);
    },
    editGunPlant(gunPlant) {
      this.editedGunPlant = gunPlant;
      this.editGunPlantDialog = true;
    }
  },
};
</script>

<style scoped lang="scss">

.gunPlantsManagement {
  padding-top: 20px;
  width: 100%;
}

.gunPlantsManagement-form {
  margin-left: 10px;
  padding-top: 30px;
  width: 95%;
}

.gunPlantsManagement-form > {
  padding-top: 20px;
}

.gunPlantsManagement-header {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  padding-bottom: 10px;
}
</style>