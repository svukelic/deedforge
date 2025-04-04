window.animateHearts = function (dotnetReference, startValue, endValue) {
    return new Promise((resolve) => {
        const isIncreasing = startValue < endValue;
        const step = isIncreasing ? 1 : -1;
        const duration = 80; // milliseconds per step
        
        // Use requestAnimationFrame for smoother animation than setTimeout
        let currentValue = startValue;
        let lastTime = 0;
        
        function animate(timestamp) {
            if (!lastTime) lastTime = timestamp;
            
            const elapsed = timestamp - lastTime;
            
            if (elapsed >= duration) {
                lastTime = timestamp;
                currentValue += step;
                
                // Update the display via .NET
                dotnetReference.invokeMethodAsync('UpdateDisplayHealth', currentValue);
                
                // Check if animation is complete
                if ((isIncreasing && currentValue >= endValue) || 
                    (!isIncreasing && currentValue <= endValue)) {
                    // Ensure final state is exact
                    dotnetReference.invokeMethodAsync('UpdateDisplayHealth', endValue);
                    resolve();
                    return;
                }
            }
            
            // Continue animation
            requestAnimationFrame(animate);
        }
        
        // Start animation
        requestAnimationFrame(animate);
    });
};