<template>
    <div>
        <v-list dense>
            <v-subheader>Marki</v-subheader>
            <v-list-item-group
                v-model="selectedItem"
                color="primary"
            >
                <v-list-item
                    v-for="brand in brandsArray"
                    :key="brand.id"
                >
                <v-list-item-icon>
                    <v-icon>mdi-pistol</v-icon>
                </v-list-item-icon>
                <v-list-item-content>
                    <v-list-item-title v-text="brand.name"></v-list-item-title>
                </v-list-item-content>
                </v-list-item>
            </v-list-item-group>
            </v-list>
    </div>
</template>

<script>
export default  {
    name: 'BrandsList',
    data: () =>  ({
        brandsArray: [
            {
                'id': 0,
                'name': 'Beretta',
            },
            {
                'id': 1,
                'name': 'Browning'
            },
            {
                'id': 2,
                'name': 'Heckler&Koch'
            }
        ]
    })

}

</script>