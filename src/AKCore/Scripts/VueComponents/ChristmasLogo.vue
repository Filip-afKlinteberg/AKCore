<template>
  <div class="snow-container">
    <h3 class="christmas" v-html="everyOtherLetter"></h3>
  </div>
</template>
<script>
export default {
  computed: {
    everyOtherLetter() {
      const text = "Alte Kamereren";
      let evenLetter = true;
      return text
        .split("")
        .map(x => {
          const cl = evenLetter ? "cb" : "cg";
          evenLetter = !evenLetter;
          return `<span class='${cl}'>${x}</span>`;
        })
        .join("");
    }
  }
};
</script>

<style lang="scss" scoped>
@import url(https://fonts.googleapis.com/css?family=Mountains+of+Christmas:700);

.snow-container {
  background-size: 100%;
  height: 300px;
  background-repeat: no-repeat;
  overflow: hidden;
  margin: 0;
  width: 100%;
  position: relative;
}
// .cb {
//   color: #035ee2;
//   background: linear-gradient(transparent, transparent), url("./Assets/blue_glitter.gif")
//       repeat;
//   background: -o-linear-gradient(transparent, transparent) !important;
//   background-clip: text !important;
//   -webkit-text-fill-color: transparent !important;
//   margin: 0;
//   padding: 0;

//   font-weight: 900;
//   width: 100%;
//   text-align: center;
//   letter-spacing: 1px;
//   z-index: 999999;
//   -webkit-background-clip: text;
// }

// .cg {
//   color: gold;
//   background: linear-gradient(transparent, transparent),
//     url("./Assets/gold_glitter.gif")
//       repeat;
//   background: -o-linear-gradient(transparent, transparent) !important;
//   background-clip: text !important;
//   -webkit-text-fill-color: transparent !important;
//   margin: 0;
//   padding: 0;
//   font-weight: 900;
//   width: 100%;
//   text-align: center;
//   letter-spacing: 1px;
//   z-index: 999999;
//   -webkit-background-clip: text;
// }

h3 {
  position: absolute;
  font-size: 8.5vw;
  width: 100%;
  height: 100%;
  text-align: center;
  max-height: 100px;
  z-index: 3;
  line-height: 0;
  margin-top: 150px;
  color: #fff;
  font-family: "Mountains of Christmas", cursive;
}


</style>