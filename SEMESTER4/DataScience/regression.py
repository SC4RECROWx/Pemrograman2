from re import X
from matplotlib import collections
import matplotlib
import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
from sklearn.linear_model import LinearRegression
#load data
delivery =  pd.read_csv('delivery.csv')
print(delivery.head())
delivery.shape


x_distance=delivery['distance'].values
X_distance=x_distance[:, np.newaxis]
y_delivery= delivery['delTime'].values

regressor = LinearRegression()
model = regressor.fit(X_distance, y_delivery)

plt.scatter(X_distance, y_delivery)
y_pred = regressor.predict(X_distance)
plt.plot(X_distance, y_pred, color='red')
