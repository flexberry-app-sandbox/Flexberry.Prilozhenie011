import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.caption'),
          title: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.title'),
          children: [{
            link: 'i-i-s-prilozhenie-01-док-план-за-на-д-l',
            caption: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-док-план-за-на-д-l.caption'),
            title: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-док-план-за-на-д-l.title'),
            icon: 'list',
            children: null
          }, {
            link: 'i-i-s-prilozhenie-01-спр-тип-транс-ср-l',
            caption: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-спр-тип-транс-ср-l.caption'),
            title: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-спр-тип-транс-ср-l.title'),
            icon: 'folder',
            children: null
          }, {
            link: 'i-i-s-prilozhenie-01-спр-трансп-ср-l',
            caption: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-спр-трансп-ср-l.caption'),
            title: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-спр-трансп-ср-l.title'),
            icon: 'address card',
            children: null
          }, {
            link: 'i-i-s-prilozhenie-01-спр-номен-l',
            caption: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-спр-номен-l.caption'),
            title: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-спр-номен-l.title'),
            icon: 'address card',
            children: null
          }, {
            link: 'i-i-s-prilozhenie-01-спр-контр-аг-l',
            caption: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-спр-контр-аг-l.caption'),
            title: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-спр-контр-аг-l.title'),
            icon: 'phone',
            children: null
          }, {
            link: 'i-i-s-prilozhenie-01-спр-ед-измер-l',
            caption: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-спр-ед-измер-l.caption'),
            title: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-спр-ед-измер-l.title'),
            icon: 'list',
            children: null
          }, {
            link: 'i-i-s-prilozhenie-01-спр-виды-раб-l',
            caption: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-спр-виды-раб-l.caption'),
            title: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-спр-виды-раб-l.title'),
            icon: 'list',
            children: null
          }, {
            link: 'i-i-s-prilozhenie-01-спр-объект-стр-l',
            caption: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-спр-объект-стр-l.caption'),
            title: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-спр-объект-стр-l.title'),
            icon: 'calendar',
            children: null
          }, {
            link: 'i-i-s-prilozhenie-01-спр-пользов-l',
            caption: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-спр-пользов-l.caption'),
            title: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-спр-пользов-l.title'),
            icon: 'calendar',
            children: null
          }, {
            link: 'i-i-s-prilozhenie-01-факт-выпол-раб-l',
            caption: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-факт-выпол-раб-l.caption'),
            title: i18n.t('forms.application.sitemap.диспетчеризация-транспортных-средств.i-i-s-prilozhenie-01-факт-выпол-раб-l.title'),
            icon: 'paperclip',
            children: null
          }]
        }
      ]
    };
  }),
})