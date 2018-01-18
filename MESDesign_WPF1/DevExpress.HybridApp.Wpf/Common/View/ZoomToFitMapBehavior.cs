using System.Collections.Generic;
using System.Windows;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Xpf.Map;

namespace DevExpress.DevAV.Common.View {
    public class ZoomToFitMapBehavior : Behavior<MapControl> {
        public ZoomToFitMapBehavior() {
            mapVectorLayers = new List<VectorLayer>();
        }
        List<VectorLayer> mapVectorLayers;

        public static readonly DependencyProperty PaddingFactorProperty =
            DependencyProperty.Register("PaddingFactor", typeof(double), typeof(ZoomToFitMapBehavior),
            new FrameworkPropertyMetadata(0.15d, (d, e) => ((ZoomToFitMapBehavior)d).OnPaddingFactorChanged(e)));
        public double PaddingFactor {
            get { return (double)GetValue(PaddingFactorProperty); }
            set { SetValue(PaddingFactorProperty, value); }
        }
        public string ZoomLayerName { get; set; }

        void OnPaddingFactorChanged(DependencyPropertyChangedEventArgs e) {
            ZoomToFit();
        }
        protected override void OnAttached() {
            base.OnAttached();
            this.AssociatedObject.Loaded += MapControlLoaded;
            this.AssociatedObject.Unloaded += MapControlUnLoaded;
        }

        protected override void OnDetaching() {
            this.AssociatedObject.Loaded -= MapControlLoaded;
            this.AssociatedObject.Unloaded -= MapControlUnLoaded;
            base.OnDetaching();
        }

        void MapControlLoaded(object sender, RoutedEventArgs e) {
            mapVectorLayers.Clear();
            foreach(var layer in this.AssociatedObject.Layers) {
                VectorLayer vectorLayer = layer as VectorLayer;
                if(vectorLayer != null && vectorLayer.Data != null && (string.IsNullOrEmpty(ZoomLayerName) ? true : vectorLayer.Name == ZoomLayerName)) {
                    mapVectorLayers.Add(vectorLayer);
                    vectorLayer.Loaded -= DisplayItemsCollectionChanged;
                    vectorLayer.Loaded += DisplayItemsCollectionChanged;
                }
            }
        }

        void MapControlUnLoaded(object sender, RoutedEventArgs e) {
            foreach(VectorLayer layer in mapVectorLayers)
                layer.Loaded -= DisplayItemsCollectionChanged;
        }

        void DisplayItemsCollectionChanged(object sender, RoutedEventArgs e) {
            ZoomToFit();
        }
        void ZoomToFit() {
            if(this.AssociatedObject != null && mapVectorLayers.Capacity > 0)
                this.AssociatedObject.ZoomToFitLayerItems(mapVectorLayers, PaddingFactor);
        }
    }
}
