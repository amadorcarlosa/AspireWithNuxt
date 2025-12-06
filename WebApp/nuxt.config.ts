export default defineNuxtConfig({
  compatibilityDate: '2025-12-05',
  devtools: { enabled: true },
  $development: {
    routeRules: {
      '/api/**': {
        proxy: 'http://localhost:5230/**',
      },
    },
  },
})
