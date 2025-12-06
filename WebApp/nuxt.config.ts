// nuxt.config.ts
export default defineNuxtConfig({
  compatibilityDate: '2025-12-05',
  devtools: { enabled: true },

  // dev-only proxy to .NET backend
  $development: {
    routeRules: {
      "/api/**": {
        proxy: "http://localhost:5230/**",
      },
    },
  },
})
